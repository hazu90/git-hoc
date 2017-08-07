var dialogs = {
    init: function () {
        $('#dialog-error').dialog({
            autoOpen: false,
            resizable: false,
            dialogClass: 'ui-dialog-red',
            open: function () {
                $('#dialog-confirm').children().detach().appendTo($('#dialog-confirm'));
            },
            show: {
                effect: "blind",
                duration: 500
            },
            modal: true,
            buttons: [
                {
                    "text": "Đóng",
                    'class': 'btn',
                    click: function () {
                        $(this).dialog("close");
                    }
                }
            ]
        });
        $('#dialog-info').dialog({
            autoOpen: false,
            resizable: false,
            dialogClass: 'ui-dialog-blue',
            open: function () {
                $('#dialog-confirm').children().detach().appendTo($('#dialog-confirm'));
            },
            show: {
                effect: "blind",
                duration: 500
            },
            modal: true,
            buttons: [
                {
                    "text": "Đóng",
                    'class': 'btn',
                    click: function () {
                        $(this).dialog("close");
                    }
                }
            ]
        });
        $('#dialog-warning').dialog({
            autoOpen: false,
            resizable: false,
            dialogClass: 'ui-dialog-yellow',
            open: function () {
                $('#dialog-confirm').children().detach().appendTo($('#dialog-confirm'));
            },
            show: {
                effect: "blind",
                duration: 500
            },
            modal: true,
            buttons: [
                {
                    "text": "Đóng",
                    'class': 'btn',
                    click: function () {
                        $(this).dialog("close");
                    }
                }]
        });
        $('#dialog-confirm').dialog({
            autoOpen: false,
            resizable: false,
            dialogClass: 'ui-dialog-green',
            open: function () {
                $('#dialog-confirm').children().detach().appendTo($('#dialog-confirm'));
            },
            show: {
                effect: "blind",
                duration: 500
            },
            modal: true,
            buttons: [
                {
                    'class': 'btn red',
                    'text': 'Đồng ý',
                    click: function () {
                        $(this).dialog("close");
                        dialogs.yes_action();
                    }
                },
                {
                    'class': 'btn',
                    'text': 'Hủy',
                    click: function () {
                        $(this).dialog("close");
                        dialogs.no_action();
                    }
                }]
        });
    },
    show: function (options) {
        if ($('.modal.in').length > 0) {
            $('.modal.in').modal('hide');
            setTimeout(function () {
                $('span.dialog-msg', options.element).html(options.message);
                if (typeof options.yes_action === 'function') {
                    dialogs.yes_action = options.yes_action;
                }
                else {
                    dialogs.yes_action = function () { };
                }

                if (typeof options.no_action === 'function') {
                    dialogs.no_action = options.no_action;
                }
                else {
                    dialogs.no_action = function () { };
                }

                options.element.dialog("open");
                $('.ui-dialog button').blur();
            }, 500);
        }
        else {
            $('span.dialog-msg', options.element).html(options.message);
            if (typeof options.yes_action === 'function') {
                dialogs.yes_action = options.yes_action;
            }
            else {
                dialogs.yes_action = function () { };
            }

            if (typeof options.no_action === 'function') {
                dialogs.no_action = options.no_action;
            }
            else {
                dialogs.no_action = function () { };
            }
            options.element.dialog("open");
            $('.ui-dialog button').blur();
        }
    },
    yes_action: function () { },
    no_action: function () { }
};