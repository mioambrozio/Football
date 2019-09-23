var MessageInfo = function (heading, text) {
    $.toast({
        heading: heading,
        text: text,
        position: 'top-right',
        loaderBg: '#ff6849',
        icon: 'info',
        hideAfter: 15000,
        stack: 6
    });
};

var MessageSucess = function (heading, text) {
    $.toast({
        heading: heading,
        text: text,
        position: 'top-right',
        loaderBg: '#ff6849',
        icon: 'success',
        hideAfter: 15000,
        stack: 6
    });
};

var MessageError = function (heading, text) {
    $.toast({
        heading: heading,
        text: text,
        position: 'top-right',
        loaderBg: '#ff6849',
        icon: 'error',
        hideAfter: 15000

    });
};

var MessageWarning = function (heading, text) {
    $.toast({
        heading: heading,
        text: text,
        position: 'top-right',
        loaderBg: '#ff6849',
        icon: 'warning',
        hideAfter: 15000,
        stack: 6
    });
};

$(function () {
    "use strict";
    $(".tst1").click(function () {
        $.toast({
            heading: 'Welcome to Monster admin',
            text: 'Use the predefined ones, or specify a custom position object.',
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'info',
            hideAfter: 15000,
            stack: 6
        });

    });

    $(".tst2").click(function () {
        $.toast({
            heading: 'Welcome to Monster admin',
            text: 'Use the predefined ones, or specify a custom position object.',
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'warning',
            hideAfter: 15000,
            stack: 6
        });

    });
    $(".tst3").click(function () {
        $.toast({
            heading: 'Welcome to Monster admin',
            text: 'Use the predefined ones, or specify a custom position object.',
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'success',
            hideAfter: 15000,
            stack: 6
        });

    });

    $(".tst4").click(function () {
        $.toast({
            heading: 'Welcome to Monster admin',
            text: 'Use the predefined ones, or specify a custom position object.',
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'error',
            hideAfter: 15000
        });

    });
});

