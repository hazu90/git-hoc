/***********************************************************************
Author  : VanDH
Desc    : Class định nghĩa các mã trả về từ Server
************************************************************************/
var ResponseCode = {
    Success: 1,
    Error: 0,
    ErrorExist: 2,
    DataNull: 3,
    ErrorParam: 4,
    NotPermitted: 5,
    NotValid: 6,
    Locked: 7,
    Overflow: 8,
    ErrorConnect: 9,
    Sync: 10
};
/***********************************************************************
 Author  : VanDH
 Desc    : Class định nghĩa các method dùng để hiển thị message
 ************************************************************************/
var library_sysmess = {
    log: function (msg) {
        console.log(msg);
    },
    info: function (msg, func) {
        dialogs.show({ element: $('#dialog-info'), message: msg, yes_action: func });
    },
    error: function (msg, func) {
        dialogs.show({ element: $('#dialog-error'), message: msg, yes_action: func });
    },
    confirm: function (msg, yes_action, no_action) {
        dialogs.show({ element: $('#dialog-confirm'), message: msg, yes_action: yes_action, no_action: no_action });
    },
    warning: function (msg, func) {
        dialogs.show({ element: $('#dialog-warning'), message: msg, yes_action: func });
    }
};
/***********************************************************************
 Author  : VanDH
 Desc    : Class định nghĩa các method dùng để gửi và nhận data
 ************************************************************************/
var library_sysrequest = {
    defaults: {
        element: null,
        blockUI: null,
        scrollUI: null,
        action: '',
        controller: '',
        type: "POST",
        data: {},
        dataType: "json",
        async: true,
        traditional: true,
        callback: function (data) { }
    },
    send: function (options) {
        var settings = $.extend({}, library_sysrequest.defaults, options);
        var url = "/" + settings.controller + (settings.action != '' ? "/" + settings.action : settings.action);
        if (settings.element == null) settings.element = $('div#main-content');
        if (settings.blockUI == null) settings.blockUI = settings.element;
        if (settings.scrollUI == null) settings.scrollUI = settings.blockUI;
        $.ajax({
            url: url,
            type: settings.type,
            data: (settings.data),
            dataType: settings.dataType,
            async: settings.async,
            traditional: settings.traditional,
            beforeSend: function () {
                App.blockUI(settings.blockUI);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('.modal.in').each(function () {
                    $(this).modal('hide');
                });
                library_sysmess.error('Có lỗi xảy ra khi gửi yêu cầu xử lý!');
                console.log(url);
                console.log(settings.data);
                console.log('Có lỗi xảy ra khi gửi yêu cầu xử lý!');
                library_sysmess.log(textStatus);
                library_sysmess.log(errorThrown);
            },
            success: function (response) {
                switch (settings.dataType) {
                    case "html":
                        settings.element.html(response);
                        settings.callback();
                        //syscommon.scroll(settings.scrollUI);
                        break;
                    case "json":
                        settings.callback(response);
                        //if (response.Notify != null && typeof dvsnotify.push === "function") {
                        //    dvsnotify.push(response.Notify);
                        //}
                        break;
                }
            },
            complete: function () {
                App.unblockUI(settings.blockUI);
            }
        });
    }
};