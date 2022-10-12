
'use strict';
var dt_experimento;
var myModaleditExperimento;
var modalExperimentoIndicador;
var statusObj;
var IdStatusExperimento = null;
$(function () {

    myModaleditExperimento = new bootstrap.Modal(document.getElementById('editExperimento'), {
        keyboard: false,
        backdrop: 'static'
    })
    modalExperimentoIndicador = new bootstrap.Modal(document.getElementById('modalExperimentoIndicador'), {
        keyboard: false,
        backdrop: 'static'
    })
    
    const flatpickrDate = document.querySelector('#modaltxtFechaSolicitud')
    
    if (flatpickrDate) {
        flatpickrDate.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    const flatpickrDate2 = document.querySelector('#modaltxtFechapublicacion')
    if (flatpickrDate2) {
        flatpickrDate2.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    const flatpickrDate3 = document.querySelector('#modaltxtFechaLanzamiento')
    if (flatpickrDate3) {
        flatpickrDate3.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    const flatpickrDate4 = document.querySelector('#modaltxtFechaInicioCronograma')
    if (flatpickrDate4) {
        flatpickrDate4.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    const flatpickrDate5 = document.querySelector('#modaltxtFechaFinCronograma')
    if (flatpickrDate5) {
        flatpickrDate5.flatpickr({
            monthSelectorType: 'static',
            dateFormat: 'd/m/Y'
        });
    }
    var dt_experimento_table = $('.datatables-users');
    statusObj = {
        0: { title: 'No', class: 'bg-label-secondary' },
        1: { title: 'Si', class: 'bg-label-success' }
    };
    // Users datatable
    if (dt_experimento_table.length) {
        //var obj = {};
        //obj.IdStatusExperimento = 10;
        dt_experimento = dt_experimento_table.DataTable({
            "ajax": {
                "url": $("#hdn_Listar_Experimento").val(),
                "type": "POST",
                "dataType": "json",
                "contentType": "application/json",
                "data": function (d) {
                    d.IdStatusExperimento = IdStatusExperimento;
                    return JSON.stringify(d);

                }
            },
            columns: [
                // columns according to JSON
                /*{ data: '' },*/
                { data: 'NombreExperimento' },
                { data: 'Descripcion' },
                { data: 'Tecnologia' },
                { data: 'DesarrolladoPor' },
                { data: 'FechaSolicitudString' },
                { data: 'FechaPublicacionString' },
                { data: 'Url' },
                { data: 'FlagPublico' },
                { data: 'action' }
            ],
            columnDefs: [
                {
                    // User Status
                    targets: 0,
                    render: function (data, type, full, meta) {
                        var $nombreExperimento = full['NombreExperimento'];

                        return '<a title="Ver Indicadores" style="cursor:pointer" onclick="ObtenerIndicadores(event,' + full.IdExperimento + ')">' + $nombreExperimento + '</a>';
                    }
                },
                {
                    // User Status
                    targets: 7,
                    render: function (data, type, full, meta) {
                        var $status = full['FlagPublico'];

                        return '<span class="badge ' + statusObj[$status === true ? 1 : 0].class + '">' + statusObj[$status === true ? 1 : 0].title + '</span>';
                    }
                },
                {
                    // Actions
                    targets: -1,
                    title: '<div data-i18n="Acciones">Acciones<div>',
                    searchable: false,
                    orderable: false,
                    render: function (data, type, full, meta) {
                        return (
                            '<div class="d-inline-block text-nowrap">' +
                            '<button onclick="ObtenerExperimento(event,' + full.IdExperimento + ')" class="btn btn-sm btn-icon" id="btn_edit_user_' + full.IdExperimento + '" ><i class="bx bx-edit"></i></button>' +
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
                    text: '<i class="bx bx-plus me-0 me-sm-2"></i><span class="d-none d-lg-inline-block">Nuevo Experimento</span>',
                    className: 'add-new btn btn-primary',
                    attr: {
                        'onclick': 'NuevoExperimento()',
                        'data-bs-toggle': 'modal',
                        'data-bs-target': '#editExperimento',
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
            //                return 'Details of ' + data['NombreExperimento'];
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
        dt_experimento.row($(this).parents('tr')).remove().draw();
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
    const experimentoForm = document.getElementById('experimentoForm');

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
    const fv = FormValidation.formValidation(experimentoForm, {
        fields: {
            modaltxtNombre: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese el Nombre del Experimento'
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
            modaltxtFechaSolicitud: {
                validators: {
                    notEmpty: {
                        message: 'Ingrese la fecha de la solicitud'
                    }
                }
            },
            //modaltxtFechapublicacion: {
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
        
        var Experimento = {};
        var UrlEjecutar = $("#hdn_Crear_Experimento").val();
        Experimento.IdExperimento = 0;

        if ($('#modalhdnIdExperimento').val() != "0") {
            Experimento.IdExperimento = $('#modalhdnIdExperimento').val();
            UrlEjecutar = $("#hdn_Modificar_Experimento").val();
        }

        Experimento.NombreExperimento = $('#modaltxtNombre').val();
        Experimento.Descripcion = $('#modaltxtDescripcion').val();
        Experimento.Tecnologia = $('#modaltxtTecnologia').val();
        Experimento.DesarrolladoPor = $('#modaltxtDesarrolladoPor').val();
        Experimento.Indicador = $('#modaltxtNombre').val();
        Experimento.FechaSolicitud = $('#modaltxtFechaSolicitud').val();
        Experimento.FechaPublicacion = $('#modaltxtFechapublicacion').val();
        Experimento.Url = $('#modaltxtUrl').val();
        Experimento.IdUsuarioContacto = $('#modaltxtNombre').val();
        Experimento.FlagPublico = $('#modalchkPublicado').is(":checked");
        Experimento.FlagEstado = true//$('#modalchkEstado').is(":checked");
        Experimento.IdStatusExperimento = $('#modalSelectIdEstado').val();

        Experimento.FechaLanzamiento = $('#modaltxtFechaLanzamiento').val();
        Experimento.IdProducto = $('#modalSelectIdProducto').val();
        Experimento.FechaInicioCronograma = $('#modaltxtFechaInicioCronograma').val();
        Experimento.FechaFinCronograma = $('#modaltxtFechaFinCronograma').val();
        Experimento.FlagExitosRapidos = $('#modalchkFlagExitosRapidos').is(":checked");
        Experimento.Plantilla = $('#modalSelectPlantilla').val();
        Experimento.TipoUsuario = $('#modalSelectTipoUsuario').val();
        
        $.ajax({
            url: UrlEjecutar,
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            processData: true,
            data: JSON.stringify(Experimento),
            success: function (response) {
                dt_experimento.ajax.reload();
                myModaleditExperimento.hide();
                Swal.fire({
                    title: $('#modalhdnIdExperimento').val() == '0' ? 'Se registro correctamente!' :'Se modifico correctamente',
                    //text: 'You clicked the button!',
                    icon: 'success',
                    customClass: {
                        confirmButton: 'btn btn-primary'
                    },
                    buttonsStyling: false
                });
            },
            failure: function (msg) {        
                console.log(msg);       
            },
            error: function (xhr, status, error) {
                console.log(error);
            },
            complete: function () {

            }
        });
    });

})();
