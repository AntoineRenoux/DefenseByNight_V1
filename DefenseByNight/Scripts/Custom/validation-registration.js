(function () {

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
                minlength: 6
            },

            'LastName': {
                required: true,
                minlength: 6
            },

            'Alias': {
                required: true,
                minlength: 6
            },

            'Email': {
                required: true,
                email: true
            },

            'Password': {
                required: true,
                minlength: 6
            },

            'ConfirmPassword': {
                required: true,
                equalTo: '#Password'
            },

            'Birthdate': {
                required: true,
                minlength: 6
            }
        },
        messages: {
            'Email': $('#err_email_missing').val(),

            'Password': {
                required: $('#err_password_missing').val(),
                minlength: $('#err_password_toshort').val(),
            }
        }
    });
})() 