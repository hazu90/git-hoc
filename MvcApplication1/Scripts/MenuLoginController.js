app_module.controller('MenuLoginController',['$scope','dialog_login',function($scope,dialog_login){
    $scope.show_login_dialog = dialog_login.show_dialog;
}]);