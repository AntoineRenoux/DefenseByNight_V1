(function () {
    $(document).ready(function () {
        $('#res_email_connexion_lbl').text($('#res_email_lbl').val());
        $('#res_password_connexion_lbl').text($('#res_password_lbl').val());
        $('#submitButton').text($('#res_connexion_lbl').val());

        $('#res_firstname_registration_lbl').text($('#res_firstname_lbl').val());
        $('#res_lastname_registration_lbl').text($('#res_lastname_lbl').val());
        $('#res_alias_registration_lbl').text($('#res_alias_lbl').val());
        $('#res_email_registration_lbl').text($('#res_email_lbl').val());
        $('#res_password_registration_lbl').text($('#res_password_lbl').val());
        $('#res_password2_registration_lbl').text($('#res_password_lbl').val());
        $('#res_birthdate_registration_lbl').text($('#res_birthdate_lbl').val());
        $('#createUser').val($('#res_registration_lbl').val());
    });

    $('#changeForm').on('click', function () {

        if ($('#changeForm').text() == $('#res_registration_lbl').val()) {
            $('#changeForm').text($('#res_connexion_lbl').val())
        }
        else {
            $('#changeForm').text($('#res_registration_lbl').val())
        }
    });
})()


