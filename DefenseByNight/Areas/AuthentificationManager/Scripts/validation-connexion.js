(function () {

    $('#connexionForm').validate({
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