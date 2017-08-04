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
 Desc    : Class định nghĩa các method dùng để gửi và nhận data
 ************************************************************************/
var sysrequest = {
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
        var settings = $.extend({}, sysrequest.defaults, options);
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
                app.blockUI(settings.blockUI);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('.modal.in').each(function () {
                    $(this).modal('hide');
                });
                sysmess.error('Có lỗi xảy ra khi gửi yêu cầu xử lý!');
                console.log(url);
                console.log(settings.data);
                //sysmess.log(textStatus);
                //sysmess.log(errorThrown);
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
                app.unblockUI(settings.blockUI);
            }
        });
    }
};