app_module.factory('dialog_login',function(){
    return {
        show_element : false,
        show_dialog:function(){
            this.show_element = true;
        },
        hide_dialog:function(){
            this.show_element = false;
        }
    }

    //var data = {
    //    show_element : false
    //};
    //var item_services = {};
    //item_services.show_dialog=function(){
    //    data.show_element = true;
    //};
    //item_services.hide_dialog=function(){
    //    data.show_element = false;
    //};
    //item_services.get_status = function(){
    //    return data;
    //}
    //return item_services;
});