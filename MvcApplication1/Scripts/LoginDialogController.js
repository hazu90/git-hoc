app_module.controller('LoginDialogController',['$scope', '$window','dialog_login',function($scope,$window,dialog_login){
    $scope.singleton = dialog_login;
    $scope.$window = $window;
    $scope.$window.onclick = function (event) {
        var clicked_element = event.target;
        if(!clicked_element)
        {
            return;
        }
        var clicked_classes = clicked_element.classList;
        var check_clicked_on_search_drawer =  clicked_classes.contains('b-modal');
        if(check_clicked_on_search_drawer){
            dialog_login.hide_dialog();
        }
    };
    $scope.close_dialog = function(){
        dialog_login.hide_dialog();
    };
}]);