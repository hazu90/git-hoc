app_module.factory('dialog_login',function(){
    this.Data = {
        show_element : false
    };
    var item_services = {};
    item_services.show_dialog=function(){
        this.Data.show_element = true;
    };
    item_services.hide_dialog=function(){
        this.Data.show_element = false;
    };
    item_services.get_status = function(){
        return this.Data;
    }
    return item_services;
});