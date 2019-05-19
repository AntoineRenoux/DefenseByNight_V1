(function () {

    $('#connexionForm').validate({
        errorClass: 'help-block animation-slideDown',
        errorElement: 'div',
        errorPlacement: function (error, e) {
            e[0].placeholder = error.text()
        },
        highlight: function (e) {
            $(e).closest('.input-group').removeClass('has-success has-error').addClass('has-error');
            $(e).closest('.help-block').remove();
        },
        success: function (e) {
            e.closest('.input-group').removeClass('has-success has-error');
            e.closest('.help-block').remove();
        },
        rules: {
            'UserName': {
                required: true
            },

            'Password': {
                required: true
            }
        },
         messages: {
            'UserName': $('#err_alias_missing').val(),

            'Password': {
                required: $('#err_password_missing').val()
            }
        }
    });
})() 