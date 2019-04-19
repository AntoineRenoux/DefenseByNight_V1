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
                minlength: 2,
                maxlenght: 20
            },

            'LastName': {
                required: true,
                minlength: 2,
                maxlenght: 20
            },

            'Alias': {
                required: true,
                minlength: 2,
                maxlenght: 40
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
                dateITA: true,
            }
        },
        messages: {
            'FirstName': {
                required: $('#err_firstname_missing').val(),
                minlength: "Erreur à traduire : Taille inférieur à 6",
                maxlength: "Erreur à traduire : Taille supérieur à 20",
            },

            'LastName': {
                required: $('#err_lastname_missing').val(),
                minlength: "Erreur à traduire : Taille inférieur à 6",
                maxlength: "Erreur à traduire : Taille supérieur à 20",
            },

            'Alias': {
                required: $('#err_alias_missing').val(),
                minlength: "Erreur à traduire : Taille inférieur à 2",
                maxlength: "Erreur à traduire : Taille supérieur à 40",
            },

            'Email': $('#err_email_missing').val(),

            'Password': {
                required: $('#err_password_missing').val(),
                minlength: $('#err_password_toshort').val(),
            },

             'ConfirmPassword': {
                 required: "Erreur à traduire : Le mdp est obligatoire",
                 equalTo: 'Erreur à traduire : Le mdp doit matcher avec password'
            },

            'Birthdate': {
                required: $('#err_birthdate_missing').val(),
                dateITA: "A traduire",
            },
        }
    });
})() 