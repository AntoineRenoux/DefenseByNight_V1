/*!
 * jquery.validation.bootstrap
 * Ibrahim Aydin : noldoreldar
 * Usage and more info : https://github.com/noldoreldar/jquery-validate-bootstrap
 */
$.validator.applyBootstrap = function () {
    var selectorIcon = "span.inp-validation-icon";
    var selectorInpGroup = ".input-group";
    var htmlEncode = function (value) {
        return $("<div/>").text(value).html();
    };
    var getClosestContentElm = function (jqInpElm) {
        return jqInpElm.closest("div,span,form");
    };
    var refreshTooltipsHandle = false;
    var refreshTooltips = function () {
        $(selectorIcon).each(function (i, errIco) {
            $(errIco).tooltip("show");
        });
        refreshTooltipsHandle = false;
    };
    var onWindowResize = function () {
        if (refreshTooltipsHandle) {
            return;
        }
        refreshTooltipsHandle = true;
        setTimeout(refreshTooltips, 500);
    };
    var removeCurrentIcon = function (jqInpElm) {
        var jqClosest = getClosestContentElm(jqInpElm);
        var jqCurrentIcon = jqClosest.find(selectorIcon);
        if (jqCurrentIcon.length > 0) {
            jqCurrentIcon.tooltip("hide");
            jqCurrentIcon.tooltip("destroy");
            jqCurrentIcon.remove();
        }
    };
    var hideValidationMessageLabel = function (jqInpElm) {
        var jqClosest = getClosestContentElm(jqInpElm);
        jqClosest.find("label.error").css("display", "none");
    };
    var addValidClass = function (jqElm) {
        jqElm.addClass("valid");
    };
    var removeValidClass = function (jqElm) {
        jqElm.removeClass("valid");
    };
    var addErrorClass = function (jqElm) {
        jqElm.addClass("has-error");
    };
    var removeErrorClass = function (jqElm) {
        jqElm.removeClass("has-error");
    };
    var initNewToolTipIcon = function (jqInpElm, message) {
        removeCurrentIcon(jqInpElm);
        var jqNewIcon = $("<span></span>");
        jqNewIcon.attr("title", htmlEncode(message));
        jqNewIcon.addClass("inp-validation-icon");
        jqNewIcon.addClass("glyphicon");
        jqNewIcon.addClass("glyphicon-exclamation-sign");
        jqNewIcon.css("display", "inline-block");
        jqNewIcon.css("position", "absolute");
        jqNewIcon.css("vertical-align", "middle");
        jqNewIcon.css("right", "0");
        jqNewIcon.css("top", "0");
        jqNewIcon.css("width", "20px");
        jqNewIcon.css("height", "1.4em");
        jqNewIcon.css("padding", " 0.4em 0");
        jqNewIcon.css("margin", "0 4px");
        jqNewIcon.css("font-size", "1.4em");
        jqNewIcon.css("z-index", "1000");
        jqNewIcon.css("color", "#a94442");
        jqNewIcon.insertAfter(jqInpElm);
        jqNewIcon.tooltip({ placement: "right", trigger: "manual", container: "body" });
        jqNewIcon.tooltip("show");
    };
    $.validator.setDefaults({
        highlight: function (element) {
            var jqInpElm = $(element);
            var jqInpGroup = jqInpElm.closest(selectorInpGroup);
            removeValidClass(jqInpElm);
            removeValidClass(jqInpGroup);
            addErrorClass(jqInpElm);
            addErrorClass(jqInpGroup);
        },
        unhighlight: function (element) {
            var jqInpElm = $(element);
            var jqInpGroup = jqInpElm.closest(selectorInpGroup);
            removeCurrentIcon(jqInpElm);
            removeErrorClass(jqInpElm);
            removeErrorClass(jqInpGroup);
            addValidClass(jqInpElm);
            addValidClass(jqInpGroup);
        },
        showErrors: function (errorMap, errorList) {
            this.defaultShowErrors();
            $.each(errorList, function (idx, errItem) {
                var jqInpElm = $(errItem.element);
                hideValidationMessageLabel(jqInpElm);
                initNewToolTipIcon(jqInpElm, errItem.message);
                $(window).off("resize", onWindowResize);
                $(window).on("resize", onWindowResize);
            });
        }
    });
};

