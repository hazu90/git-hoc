app_module.controller('CityController',['$scope', '$window',function($scope,$window){
    $scope.isOpen = false;
    $scope.$window = $window;
    $scope.selectedItem = 'Hà Nội';
    $scope.lstCssStyle = 'lst-select-items minw280 hide';
    $scope.show_lst_items = function(){
        $scope.isOpen = !$scope.isOpen;
        if($scope.isOpen)
        {
            $scope.lstCssStyle = 'lst-select-items minw280';

        }
        else
        {
            $scope.lstCssStyle = 'lst-select-items minw280 hide';
        }
    };

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
        var check_clicked_on_search_drawer =  clicked_classes.contains('show-selected-item')
                                            ||clicked_classes.contains('lst-select-items')
                                            ||clicked_classes.contains('show-selected-item-label')
                                            ||clicked_classes.contains('show-selected-item-icon');
        if(!check_clicked_on_search_drawer){
                $scope.lstCssStyle = 'lst-select-items minw280 hide';
                $scope.isOpen = false;
                $scope.$apply();
        }
    }
}]);