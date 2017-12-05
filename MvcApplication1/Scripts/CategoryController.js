app_module.controller('CategoryController',['$scope',function($scope){
    $scope.isOpen = false;
    $scope.selectedItem = 'Ăn uống';
    $scope.show_lst_items = function(){
        $scope.isOpen = !$scope.isOpen;
    };
    $scope.hide = function () {
        $scope.isOpen = false;
    }
}]);