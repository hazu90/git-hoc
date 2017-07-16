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
});