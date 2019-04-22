var LoginModule = (function ($) {
    var self = {};

    self.SignIn = function (data) {
        if (data.success) {
            window.location = "/Home/Index?userId=" + data.message;
        }
        else {
            $('#ErrLoginFailed').text(data.message);
            $('#ErrLoginFailed').show();
        }
    };

    return self;
})($, LoginModule)