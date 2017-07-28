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
    ErrorConnect: 7,
    Overflow: 8
};

var main_frame = {
    init: function () {
        $(document).ready(function () {
            main_frame.menu_item_action();
            // uniform tất cả
        });
    },
    highlight_menu_item:function(index){
        $("li",$('#lst-menu-items' )).each(function () {
            var indexElement = $(this).index();
            if(indexElement == index)
            {
                $('a',$(this)).attr('style','color: #fff;background-color: transparent;');
            }
            else
            {
                $('a',$(this)).attr('style','color: #999;');
            }
        });
    },
    menu_item_action: function () {
        $("#lst-menu-items li a").each(function () {
            $(this).off('click').on("click", function () {
                var controllerName = $(this).attr("controller");
                var actionName = $(this).attr("action");
                var itemIndex = $(this).parent().index();
                main_frame.highlight_menu_item(itemIndex);
                $.ajax({
                    url: "/" + controllerName + "/" + actionName,
                    type: "GET",
                    data: {},
                    dataType: "html",
                    async: true,
                    beforeSend: function () {
                    },
                    error: function (jqXHR, textStatus, errorThrown) { },
                    success: function (response) {
                        $("#main-content").html(response);
                    },
                    complete: function () {
                    }
                });
            });
        });

        $("#main-home").off("click");
        $("#main-home").on("click", function () {
            var controllerName = $(this).attr("controller");
            var actionName = $(this).attr("action");
            $.ajax({
                url: "/" + controllerName + "/" + actionName,
                type: "GET",
                data: {},
                dataType: "html",
                async: true,
                beforeSend: function () { },
                error: function (jqXHR, textStatus, errorThrown) { },
                success: function (response) {
                    $("#main-content").html(response);
                },
                complete: function () {
                }
            });
        });
    }
};

var sysmess={
    success:function(message,func){
        var html='<div id="dialogSuccess" style="width: 420px; display: block; top: 40%; left: 40%;  overflow-x: hidden; overflow-y: hidden !important;outline:0;"  class="modal fade" tabindex="-1" role="dialog" aria-labelledby="dialogSuccessLabel" aria-hidden="true">'
                +'  <div class="modal-dialog" role="document" style="padding: 0px;border: none;">'
                +'      <div class="modal-content" style="border-radius:0px;width: 420px;">'
                +'          <div class="modal-header" style="color: #fff;background-color: #428bca;border-color: #357ebd;">'
                +'              <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>'
                +'              <h4 class="modal-title" id="dialogSuccessLabel">Thông báo</h4>'
                +'          </div>'
                +'          <div class="modal-body">'
                +'              <div class="row ">'
                +                   '&nbsp;&nbsp;'+'<b>THÀNH CÔNG : </b>'+message
                +'              </div>'
                +'          </div>'
                +'          <div class="modal-footer" style="padding: 5px 10px 5px 10px;">'
                +'              <button type="button" class="btn white " data-dismiss="modal"><i class="icon-remove"></i>&nbsp;Đóng</button>'
                +'          </div>'
                +'      </div>'
                +'  </div>'
                +'</div>';
        $('#dialog-system').html(html);
        $('#dialogSuccess').modal('toggle');
        $('#dialogSuccess').modal({
            backdrop:true,
            keyboard:true,
            show:true
        });
        if(typeof(func) ==='function' )
            func();
    },
    warning:function(message,func){
        var html='<div id="dialogWarning" class="modal fade" style="width: 420px; display: block; top: 40%; left: 40%; height: 178px; overflow-x: hidden; overflow-y: hidden !important;outline:0;"  data-backdrop="true" data-keyboard="true" tabindex="-1" role="dialog" aria-labelledby="dialogSuccessLabel" aria-hidden="true">'
                +'  <div class="modal-dialog" role="document" style="height: 100%;padding: 0px;border: none;">'
                +'      <div class="modal-content" style="border-radius:0px;width: 420px;">'
                +'          <div class="modal-header" style="color: #fff;background-color: #f0ad4e;border-color: #f0ad4e;">'
                +'              <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>'
                +'              <h4 class="modal-title" id="dialogSuccessLabel"><i class="icon-warning-sign"></i>&nbsp;Thông báo</h4>'
                +'          </div>'
                +'          <div class="modal-body" style="padding-top: 10px;padding-bottom: 10px;">'
                +'              <div class="row ">'
                +                   '&nbsp;&nbsp;'+'<b>CẢNH BÁO : </b>'+message
                +'              </div>'
                +'          </div>'
                +'          <div class="modal-footer" style="padding: 5px 10px 5px 10px;">'
                +'              <button type="button" class="btn white pull-right" data-dismiss="modal"><i class="icon-remove"></i>&nbsp;Đóng</button>'
                +'          </div>'
                +'      </div>'
                +'  </div>'
                +'</div>';
        $('#dialog-system').html(html);
        $('#dialogWarning').modal('toggle');
        $('#dialogWarning').modal({
            backdrop:true,
            keyboard:true,
            show:true
        });
        if(typeof(func) ==='function' )
            func();
    },
    error:function(message,func){
        var html='<div id="dialogError" style="width: 420px; display: block; top: 40%; left: 40%; height: 178px; overflow-x: hidden; overflow-y: hidden !important;outline:0;"  class="modal fade" tabindex="-1" role="dialog" aria-labelledby="dialogSuccessLabel" aria-hidden="true">'
            +'  <div class="modal-dialog" role="document" style="height: 100%;padding: 0px;border: none;">'
            +'      <div class="modal-content" style="border-radius:0px;width: 420px;">'
            +'          <div class="modal-header" style="color: #fff;background-color: #d9534f;border-color: #d43f3a;">'
            +'              <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>'
            +'              <h4 class="modal-title" id="dialogSuccessLabel">Lỗi</h4>'
            +'          </div>'
            +'          <div class="modal-body">'
            +'              <div class="row ">'
            +                   '&nbsp;&nbsp;'+'<b>LỖI : </b>'+message
            +'              </div>'
            +'              <div class="row ">'
            +'                  <button type="button" class="btn white pull-right" data-dismiss="modal"><i class="icon-remove"></i>&nbsp;Đóng</button>'
            +'              </div>'
            +'          </div>'
            +'      </div>'
            +'  </div>'
            +'</div>';
        $('#dialog-system').html(html);
        $('#dialogError').modal('toggle');
        $('#dialogError').modal({
            backdrop:true,
            keyboard:true,
            show:true
        });
        if(typeof(func) ==='function' )
            func();
    },
    confirm:function(message,func){
        var html='<div id="dialogConfirm" style="overflow-y:hidden !important;"  class="modal fade" tabindex="-1" role="dialog" aria-labelledby="dialogSuccessLabel" aria-hidden="true">'
            +'  <div class="modal-dialog" role="document" style="height: 100%;">'
            +'      <div class="modal-content" style="border-radius:0px;top: 40%;width: 420px;">'
            +'          <div class="modal-header" style="color: #fff;background-color: #5cb85c;border-color: #4cae4c">'
            +'              <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>'
            +'              <h4 class="modal-title" id="dialogSuccessLabel">Xác nhận</h4>'
            +'          </div>'
            +'          <div class="modal-body">'
            +'              <div class="row ">'
            +                   '&nbsp;&nbsp;'+message
            +'              </div>'
            +'          </div>'
            +'          <div class="modal-footer" style="padding: 5px 10px 5px 10px;">'
            +'              <button type="button btn-primary" id="btnConfirmYes" class="btn btn-success"><i class="icon-save"></i>&nbsp;Lưu</button>'
            +'              <button type="button" class="btn white" data-dismiss="modal"><i class="icon-remove"></i>&nbsp;Đóng</button>'
            +'          </div>'
            +'      </div>'
            +'  </div>'
            +'</div>';
        $('#dialog-system').html(html);
        $('#dialogConfirm').modal({
            backdrop:true,
            keyboard:true,
            show:true
        });
        $('#btnConfirmYes',$('#dialogConfirm')).off('click');
        $('#btnConfirmYes',$('#dialogConfirm')).on('click',function(){
            $('#dialogConfirm').modal('hide');
            func();
        });
    }
};
var sys_call_ajax = {
    call_json_type:function(controller,action,data,block_element,callback){
        $.ajax({
            url: '/'+controller+'/'+action,
            type: "POST",
            data: data,
            dataType: "json",
            async: true,
            beforeSend: function () {
                if(block_element !== null)
                {
                    block_element.attr("disabled","disabled",function(){});
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                sysmess.error("Có lỗi trong quá trình xử lý", function () {});
            },
            success: function (response) {
                callback(response);
            },
            complete: function () {
                if(block_element !== null)
                {
                    block_element.removeAttr("disabled");
                }

            }
        });
    },
    call_html_type:function(controller,action,data,block_element,callback){

    }
}