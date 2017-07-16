app_module.controller('AdditionalNavigationController',['$scope',function($scope){
    $scope.is_show = false;
    $scope.toggle_detail = function(){
        $scope.is_show = !$scope.is_show;
    };

    $scope.hide = function(){
        $scope.is_show = false;
    }
}]);