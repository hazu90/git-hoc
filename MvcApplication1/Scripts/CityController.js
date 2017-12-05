app_module.controller('CityController',['$scope',function($scope){
    $scope.isOpen = false;
    $scope.selectedItem = 'Hà Nội';
    $scope.show_lst_items = function(){
        $scope.isOpen = !$scope.isOpen;
    };
    
    $scope.hide = function () {
        $scope.isOpen = false;
    }
}]);