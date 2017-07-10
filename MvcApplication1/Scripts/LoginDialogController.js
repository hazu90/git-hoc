app_module.controller('LoginDialogController',['$scope', '$window','dialog_login',function($scope,$window,dialog_login){
    $scope.show_dialog = dialog_login.Data.show_element;
    $scope.$window = $window;
    $scope.$window.onclick = function (event) {
        close_when_click_else_where(event);
    };
    function close_when_click_else_where(event){
        var clicked_element = event.target;
        if(!clicked_element)
        {
            return;
        }
        var clicked_classes = clicked_element.classList;
        var check_clicked_on_search_drawer =  clicked_classes.contains('b-modal');
        if(check_clicked_on_search_drawer){
            $scope.show_dialog = false;
            $scope.$apply();
        }
    }
    $scope.close_dialog = function(){
        $scope.show_dialog = false;
    };
}]);