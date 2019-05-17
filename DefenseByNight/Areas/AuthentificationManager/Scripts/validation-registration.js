﻿(function () {

    $('#registrationForm').validate({
        errorClass: 'help-block animation-slideDown',
        errorElement: 'div',
        errorPlacement: function (error, e) {
            e.parents('.form-group > div').append(error);
        },
        highlight: function (e) {
            $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
            $(e).closest('.help-block').remove();
        },
        success: function (e) {
            e.closest('.form-group').removeClass('has-success has-error');
            e.closest('.help-block').remove();
        },
        rules: {
            'FirstName': {
                required: true,
                maxlength: 20
            },

            'LastName': {
                required: true,
                maxlength: 20
            },

            'Alias': {
                required: true,
                maxlength: 20
            },

            'Email': {
                required: true,
                email: true
            },

            'Password': {
                required: true,
                minlength: 8
            },

            'ConfirmPassword': {
                required: true,
                equalTo: '#Password'
            },

            'Birthdate': {
                required: true,
                dateITA: true
            },

            'MobilePhone': {
                required: true
            }
        },
        messages: {
            'FirstName': {
                required: $('#err_firstname_missing').val(),
                maxlength: $('#err_firstname_to_long').val()
            },

            'LastName': {
                required: $('#err_lastname_missing').val(),
                maxlength: $('#err_lastname_to_long').val()
            },

            'Alias': {
                required: $('#err_alias_missing').val(),
                maxlength: $('#err_alias_to_long').val()
            },

            'Email': {
                required: $('#err_email_missing').val(),
                email: $('#err_email_uncorrect').val()
            },

            'Password': {
                required: $('#err_password_missing').val(),
                minlength: $('#err_password_toshort').val()
            },

            'ConfirmPassword': {
                required: $('#err_password_missing').val(),
                equalTo: $('#err_password_not_matching').val()
            },

            'MobilePhone': {
                required: $('#err_password_missing').val()
            },           

            'Birthdate': {
                required: $('#err_birthdate_missing').val(),
                dateITA: "A traduire"
            },
        }
    });
})() 