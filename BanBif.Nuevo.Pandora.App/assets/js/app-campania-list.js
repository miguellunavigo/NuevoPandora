/**
 * Page User List
 */

'use strict';
var dt_campania;
var myModaleditCampania;
$(function () {

    myModaleditCampania = new bootstrap.Modal(document.getElementById('editCampania'), {
        keyboard: false,
        backdrop: 'static'
    })
    const flatpickrDate = document.querySelector('#modaltxtFechaInicio')
    const flatpickrDate2 = document.querySelector('#modaltxtFechaFin')
    if (flatpickrDate) {
        flatpickrDate.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    if (flatpickrDate2) {
        flatpickrDate2.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    var dt_campania_table = $('.datatables-users');

    // Users datatable
    if (dt_campania_table.length) {
        
        dt_campania = dt_campania_table.DataTable({
            "ajax": {
                "url": $("#hdn_Listar_Campania").val(),
                "type": "POST",
                "contentType": "application/json"//,
                //"data": JSON.stringify({ "applications": ["sca", "www"] })
            },


            //reponsive: true,
            //scrollY: "300px",
            //scrollX: true,
            //scrollCollapse: true,
            //paging: false,
            //fixedColumns: {
            //    left: 1,
            //    right: 1
            //},

            columns: [
                { data: 'NombreCampania' },
                { data: 'FechaInicioString' },
                { data: 'FechaFinString' },
                { data: 'TextoPrimario' },
                { data: 'UrlCampania' },
                { data: 'Estado' },

                { data: 'action' }
            ],
            columnDefs: [
                //{
                //    // For Responsive
                //    className: 'control',
                //    searchable: false,
                //    orderable: false,
                //    responsivePriority: 2,
                //    targets: 0,
                //    render: function (data, type, full, meta) {
                //        return '+';
                //    }
                //},
                //{
                //    // User full name and email
                //    targets: 1,
                //    responsivePriority: 4,
                //    render: function (data, type, full, meta) {

                //        var $name = full['Nombre'],
                //            $email = full['Correo'],
                //            $image = full['avatar'];
                //        if ($image) {
                //            // For Avatar image
                //            var $output =
                //                '<img src="' + assetsPath + '/img/avatars/' + $image + '" alt="Avatar" class="rounded-circle">';
                //        } else {
                //            // For Avatar badge
                //            var stateNum = Math.floor(Math.random() * 6);
                //            var states = ['success', 'danger', 'warning', 'info', 'dark', 'primary', 'secondary'];
                //            var $state = states[stateNum],
                //                $name = full['Nombre'],
                //                $initials = $name.match(/\b\w/g) || [];
                //            $initials = (($initials.shift() || '') + ($initials.pop() || '')).toUpperCase();
                //            $output = '<span class="avatar-initial rounded-circle bg-label-' + $state + '">' + $initials + '</span>';
                //        }
                //        // Creates full output for row
                //        var $row_output =
                //            '<div class="d-flex justify-content-start align-items-center user-name">' +
                //            '<div class="avatar-wrapper">' +
                //            '<div class="avatar avatar-sm me-3">' +
                //            $output +
                //            '</div>' +
                //            '</div>' +
                //            '<div class="d-flex flex-column">' +
                //            '<a href="' +
                //            userView +
                //            '" class="text-body text-truncate"><span class="fw-semibold">' +
                //            $name +
                //            '</span></a>' +
                //            '<small class="text-muted">' +
                //            $email +
                //            '</small>' +
                //            '</div>' +
                //            '</div>';
                //        return $row_output;
                //    }
                //},        
                //{
                //    // User Status
                //    targets: 3,
                //    render: function (data, type, full, meta) {
                //        var $status = full['FlagEstado'];
                //        return '<span class="badge ' + statusObj[$status === true ? 1 : 0].class + '">' + statusObj[$status === true ? 1 : 0].title + '</span>';
                //    }
                //},
                {
                    // Actions
                    targets: -1,
                    title: 'Actions',
                    searchable: false,
                    orderable: false,
                    render: function (data, type, full, meta) {
                        return (
                            '<div class="d-inline-block text-nowrap">' +
                            '<button onclick="ObtenerCampania(event,' + full.IdCampania + ')" class="btn btn-sm btn-icon" id="btn_edit_user_' + full.IdCampania + '" ><i class="bx bx-edit"></i></button>' +
                            //'<button class="btn btn-sm btn-icon delete-record"><i class="bx bx-trash"></i></button>' +
                            //'<button class="btn btn-sm btn-icon dropdown-toggle hide-arrow" data-bs-toggle="dropdown"><i class="bx bx-dots-vertical-rounded"></i></button>' +
                            '</div>'
                        );
                    }
                }
            ],
            order: [[1, 'desc']],
            dom:
                '<"row mx-2"' +
                '<"col-md-2"<"me-3"l>>' +
                '<"col-md-10"<"dt-action-buttons text-xl-end text-lg-start text-md-end text-start d-flex align-items-center justify-content-end flex-md-row flex-column mb-3 mb-md-0"fB>>' +
                '>t' +
                '<"row mx-2"' +
                '<"col-sm-12 col-md-6"i>' +
                '<"col-sm-12 col-md-6"p>' +
                '>',
            language: {
                sLengthMenu: '_MENU_',
                search: '',
                searchPlaceholder: 'Buscando..'
            },
            // Buttons with Dropdown
            buttons: [
                {
                    extend: 'collection',
                    className: 'btn btn-label-secondary dropdown-toggle mx-3',
                    text: '<i class="bx bx-upload me-2"></i>Export',
                    buttons: [
                        {
                            extend: 'print',
                            text: '<i class="bx bx-printer me-2" ></i>Print',
                            className: 'dropdown-item',
                            exportOptions: {
                                columns: [1, 2, 3, 4, 5],
                                // prevent avatar to be print
                                format: {
                                    body: function (inner, coldex, rowdex) {
                                        if (inner.length <= 0) return inner;
                                        var el = $.parseHTML(inner);
                                        var result = '';
                                        $.each(el, function (index, item) {
                                            if (item.classList !== undefined && item.classList.contains('user-name')) {
                                                result = result + item.lastChild.firstChild.textContent;
                                            } else if (item.innerText === undefined) {
                                                result = result + item.textContent;
                                            } else result = result + item.innerText;
                                        });
                                        return result;
                                    }
                                }
                            },
                            customize: function (win) {
                                //customize print view for dark
                                $(win.document.body)
                                    .css('color', config.colors.headingColor)
                                    .css('border-color', config.colors.borderColor)
                                    .css('background-color', config.colors.body);
                                $(win.document.body)
                                    .find('table')
                                    .addClass('compact')
                                    .css('color', 'inherit')
                                    .css('border-color', 'inherit')
                                    .css('background-color', 'inherit');
                            }
                        },
                        {
                            extend: 'csv',
                            text: '<i class="bx bx-file me-2" ></i>Csv',
                            className: 'dropdown-item',
                            exportOptions: {
                                columns: [1, 2, 3, 4, 5],
                                // prevent avatar to be display
                                format: {
                                    body: function (inner, coldex, rowdex) {
                                        if (inner.length <= 0) return inner;
                                        var el = $.parseHTML(inner);
                                        var result = '';
                                        $.each(el, function (index, item) {
                                            if (item.classList !== undefined && item.classList.contains('user-name')) {
                                                result = result + item.lastChild.firstChild.textContent;
                                            } else if (item.innerText === undefined) {
                                                result = result + item.textContent;
                                            } else result = result + item.innerText;
                                        });
                                        return result;
                                    }
                                }
                            }
                        },
                        {
                            extend: 'excel',
                            text: 'Excel',
                            className: 'dropdown-item',
                            exportOptions: {
                                columns: [1, 2, 3, 4, 5],
                                // prevent avatar to be display
                                format: {
                                    body: function (inner, coldex, rowdex) {
                                        if (inner.length <= 0) return inner;
                                        var el = $.parseHTML(inner);
                                        var result = '';
                                        $.each(el, function (index, item) {
                                            if (item.classList !== undefined && item.classList.contains('user-name')) {
                                                result = result + item.lastChild.firstChild.textContent;
                                            } else if (item.innerText === undefined) {
                                                result = result + item.textContent;
                                            } else result = result + item.innerText;
                                        });
                                        return result;
                                    }
                                }
                            }
                        },
                        {
                            extend: 'pdf',
                            text: '<i class="bx bxs-file-pdf me-2"></i>Pdf',
                            className: 'dropdown-item',
                            exportOptions: {
                                columns: [1, 2, 3, 4, 5],
                                // prevent avatar to be display
                                format: {
                                    body: function (inner, coldex, rowdex) {
                                        if (inner.length <= 0) return inner;
                                        var el = $.parseHTML(inner);
                                        var result = '';
                                        $.each(el, function (index, item) {
                                            if (item.classList !== undefined && item.classList.contains('user-name')) {
                                                result = result + item.lastChild.firstChild.textContent;
                                            } else if (item.innerText === undefined) {
                                                result = result + item.textContent;
                                            } else result = result + item.innerText;
                                        });
                                        return result;
                                    }
                                }
                            }
                        },
                        {
                            extend: 'copy',
                            text: '<i class="bx bx-copy me-2" ></i>Copy',
                            className: 'dropdown-item',
                            exportOptions: {
                                columns: [1, 2, 3, 4, 5],
                                // prevent avatar to be display
                                format: {
                                    body: function (inner, coldex, rowdex) {
                                        if (inner.length <= 0) return inner;
                                        var el = $.parseHTML(inner);
                                        var result = '';
                                        $.each(el, function (index, item) {
                                            if (item.classList !== undefined && item.classList.contains('user-name')) {
                                                result = result + item.lastChild.firstChild.textContent;
                                            } else if (item.innerText === undefined) {
                                                result = result + item.textContent;
                                            } else result = result + item.innerText;
                                        });
                                        return result;
                                    }
                                }
                            }
                        }
                    ]
                },
                {
                    text: '<i class="bx bx-plus me-0 me-sm-2"></i><span class="d-none d-lg-inline-block">Nuevo Campania</span>',
                    className: 'add-new btn btn-primary',
                    attr: {
                        'onclick': 'NuevoCampania()',
                        'data-bs-toggle': 'modal',
                        'data-bs-target': '#editCampania',
                        'backdrop': 'static'
                    }
                }
            ],
            // For responsive popup
            //responsive: {
            //    details: {
            //        display: $.fn.dataTable.Responsive.display.modal({
            //            header: function (row) {
            //                var data = row.data();
            //                return 'Details of ' + data['NombreCampania'];
            //            }
            //        }),
            //        type: 'column',
            //        renderer: function (api, rowIdx, columns) {
            //            var data = $.map(columns, function (col, i) {
            //                return col.title !== '' // ? Do not show row in modal popup if title is blank (for check box)
            //                    ? '<tr data-dt-row="' +
            //                    col.rowIndex +
            //                    '" data-dt-column="' +
            //                    col.columnIndex +
            //                    '">' +
            //                    '<td>' +
            //                    col.title +
            //                    ':' +
            //                    '</td> ' +
            //                    '<td>' +
            //                    col.data +
            //                    '</td>' +
            //                    '</tr>'
            //                    : '';
            //            }).join('');

            //            return data ? $('<table class="table"/><tbody />').append(data) : false;
            //        }
            //    }
            //},
            initComplete: function () {
                //// Adding role filter once table initialized
                //this.api()
                //    .columns(2)
                //    .every(function () {
                //        var column = this;
                //        var select = $(
                //            '<select id="UserRole" class="form-select text-capitalize"><option value=""> Select Role </option></select>'
                //        )
                //            .appendTo('.user_role')
                //            .on('change', function () {
                //                var val = $.fn.dataTable.util.escapeRegex($(this).val());
                //                column.search(val ? '^' + val + '$' : '', true, false).draw();
                //            });

                //        column
                //            .data()
                //            .unique()
                //            .sort()
                //            .each(function (d, j) {
                //                select.append('<option value="' + d + '">' + d + '</option>');
                //            });
                //    });
                //// Adding plan filter once table initialized
                //this.api()
                //    .columns(3)
                //    .every(function () {
                //        var column = this;
                //        var select = $(
                //            '<select id="UserPlan" class="form-select text-capitalize"><option value=""> Select Plan </option></select>'
                //        )
                //            .appendTo('.user_plan')
                //            .on('change', function () {
                //                var val = $.fn.dataTable.util.escapeRegex($(this).val());
                //                column.search(val ? '^' + val + '$' : '', true, false).draw();
                //            });

                //        column
                //            .data()
                //            .unique()
                //            .sort()
                //            .each(function (d, j) {
                //                select.append('<option value="' + d + '">' + d + '</option>');
                //            });
                //    });
                //// Adding status filter once table initialized
                //this.api()
                //    .columns(5)
                //    .every(function () {
                //        var column = this;
                //        var select = $(
                //            '<select id="FilterTransaction" class="form-select text-capitalize"><option value=""> Select Status </option></select>'
                //        )
                //            .appendTo('.user_status')
                //            .on('change', function () {
                //                var val = $.fn.dataTable.util.escapeRegex($(this).val());
                //                column.search(val ? '^' + val + '$' : '', true, false).draw();
                //            });

                //        column
                //            .data()
                //            .unique()
                //            .sort()
                //            .each(function (d, j) {
                //                select.append(
                //                    '<option value="' +
                //                    statusObj[d].title +
                //                    '" class="text-capitalize">' +
                //                    statusObj[d].title +
                //                    '</option>'
                //                );
                //            });
                //    });
            }
        });
    }

    // Delete Record
    $('.datatables-users tbody').on('click', '.delete-record', function () {
        dt_campania.row($(this).parents('tr')).remove().draw();
    });

    // Filter form control to default size
    // ? setTimeout used for multilingual table initialization
    setTimeout(() => {
        $('.dataTables_filter .form-control').removeClass('form-control-sm');
        $('.dataTables_length .form-select').removeClass('form-select-sm');
    }, 300);
});

// Validation & Phone mask
(function () {
    //const phoneMaskList = document.querySelectorAll('.phone-mask'),
    const campaniaForm = document.getElementById('campaniaForm');

    //// Phone Number
    //if (phoneMaskList) {
    //    phoneMaskList.forEach(function (phoneMask) {
    //        new Cleave(phoneMask, {
    //            phone: true,
    //            phoneRegionCode: 'US'
    //        });
    //    });
    //}
    //// Add New User Form Validation
    const fv = FormValidation.formValidation(campaniaForm, {
        fields: {
            modaltxtNombre: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese el Nombre del Campania'
                    }
                }
            },
            modaltxtDescripcion: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese Nombre Completo'
                    }
                }
            },
            modaltxtTecnologia: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese La tecnolocia'
                    }
                    //    emailAddress: {
                    //        message: 'El valor ingresado no corresponde a un correo electronico'
                    //    }
                }
            },
            modaltxtDesarrolladoPor: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese quien lo desarrollo'
                    }
                }
            },
            modaltxtFechaInicio: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese la fecha de la solicitud'
                    }
                }
            },
            //modaltxtFechaFin: {
            //    validators: {
            //        notEmpty: {
            //            message: 'Ingrese Nombre Completo'
            //        }
            //    }
            //},
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap5: new FormValidation.plugins.Bootstrap5({
                // Use this for enabling/changing valid/invalid class
                eleValidClass: '',
                rowSelector: function (field, ele) {
                    // field is the field name & ele is the field element
                    return '.validate';
                }
            }),
            submitButton: new FormValidation.plugins.SubmitButton(),
            // Submit the form when all fields are valid
            // defaultSubmit: new FormValidation.plugins.DefaultSubmit(),
            autoFocus: new FormValidation.plugins.AutoFocus()
        }
    }).on('core.form.valid', function () {

        var Campania = {};
        var UrlEjecutar = $("#hdn_Crear_Campania").val();
        Campania.IdCampania = 0;
       
        if ($('#hdn_user_id').val() != "0") {
            Campania.IdCampania = $('#modalhdnIdCampania').val();
            UrlEjecutar = $("#hdn_Modificar_Campania").val();
        }

        Campania.NombreCampania = $('#modaltxtNombre').val();
        Campania.Descripcion = $('#modaltxtDescripcion').val();
        Campania.Tecnologia = $('#modaltxtTecnologia').val();
        Campania.DesarrolladoPor = $('#modaltxtDesarrolladoPor').val();
        Campania.Indicador = $('#modaltxtNombre').val();
        Campania.FechaInicio = $('#modaltxtFechaInicio').val();
        Campania.FechaFin = $('#modaltxtFechaFin').val();
        Campania.Url = $('#modaltxtUrl').val();
        Campania.IdUsuarioContacto = $('#modaltxtNombre').val();
        Campania.FlagPublico = $('#modalchkPublicado').is(":checked");
        Campania.FlagEstado = true//$('#modalchkEstado').is(":checked");
        Campania.IdStatusCampania = $('#modalSelectIdEstado').val();


        $.ajax({
            url: UrlEjecutar,
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            processData: true,
            data: JSON.stringify(Campania),
            success: function (response) {
                alert("exitoso")
                dt_campania.ajax.reload();                
                myModaleditCampania.hide();
            },
            failure: function (msg) {
                debugger
                console.log(msg);
                // $.unblockUI();
            },
            error: function (xhr, status, error) {
                debugger
                console.log(error);
                //$.unblockUI();
            },
            complete: function () {
                debugger
                //$.unblockUI();
                //$("#prueba").dialog("close")
            }
        });
    });

})();
