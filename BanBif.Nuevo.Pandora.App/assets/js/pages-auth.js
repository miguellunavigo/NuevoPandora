'use strict';
const formAuthentication = document.querySelector('#formAuthentication');
document.addEventListener('DOMContentLoaded', function (e) {
    (function () {
        if (window.location.search.substring(1) != "") {
            $("#hdnPasswordIncorrecto").show();
        }
        if (formAuthentication) {
            const fv = FormValidation.formValidation(formAuthentication, {
                fields: {
                    username: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter username'
                            },
                            stringLength: {
                                min: 6,
                                message: 'Username must be more than 6 characters'
                            }
                        }
                    },
                    email: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter your email'
                            },
                            emailAddress: {
                                message: 'Please enter valid email address'
                            }
                        }
                    },
                    'email-username': {
                        validators: {
                            notEmpty: {
                                message: 'Please enter email / username'
                            },
                            stringLength: {
                                min: 6,
                                message: 'Username must be more than 6 characters'
                            }
                        }
                    },
                    password: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter your password'
                            },
                            stringLength: {
                                min: 6,
                                message: 'Password must be more than 6 characters'
                            }
                        }
                    },
                    'confirm-password': {
                        validators: {
                            notEmpty: {
                                message: 'Please confirm password'
                            },
                            identical: {
                                compare: function () {
                                    return formAuthentication.querySelector('[name="password"]').value;
                                },
                                message: 'The password and its confirm are not the same'
                            },
                            stringLength: {
                                min: 6,
                                message: 'Password must be more than 6 characters'
                            }
                        }
                    },
                    terms: {
                        validators: {
                            notEmpty: {
                                message: 'Please agree terms & conditions'
                            }
                        }
                    }
                },
                plugins: {
                    trigger: new FormValidation.plugins.Trigger(),
                    bootstrap5: new FormValidation.plugins.Bootstrap5({
                        eleValidClass: '',
                        rowSelector: '.mb-3'
                    }),
                    submitButton: new FormValidation.plugins.SubmitButton({
                        buttons: function (form) {
                            return [].slice.call(document.getElementById('idLogin'));
                        },
                    }),

                    defaultSubmit: new FormValidation.plugins.DefaultSubmit(),
                    autoFocus: new FormValidation.plugins.AutoFocus()
                },
                init: instance => {
                    instance.on('plugins.message.placed', function (e) {
                        if (e.element.parentElement.classList.contains('input-group')) {
                            e.element.parentElement.insertAdjacentElement('afterend', e.messageElement);
                        }
                    });
                }
            }).on('core.form.valid', function (e) {                
                var request = {
                    Username: "zoluxiones31",
                    Password: "demo123"
                }
                $.ajax({
                    url: sessionStorage.URL + '/Login/Autenticacion',
                    type: "POST",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    async: false,
                    data: JSON.stringify(request),
                    success: function (response) {
                        if (response.Result) {
                            location.href = sessionStorage.URL + '/Home/Index';
                        } else {
                            location.href = sessionStorage.URL + "?msj=true";
                        }
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        alert(xhr.status);
                        alert(thrownError);
                    }

                });
                //return false;
            });
        }
        const numeralMask = document.querySelectorAll('.numeral-mask');
        if (numeralMask.length) {
            numeralMask.forEach(e => {
                new Cleave(e, {
                    numeral: true
                });
            });
        }
    })();
});
