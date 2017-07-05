app_module.controller('RegisterController',['$scope',function($scope){
    $scope.img_correct='correct-icon.png';
    $scope.img_noncorrect='uncorrect-icon.png';
    $scope.firstname='';
    $scope.firstname_validate=$scope.img_correct;
    $scope.firstname_validate_style="{'display':'none'}";
    $scope.required = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.firstname_validate= $scope.img_noncorrect;
        }
        else
        {
            $scope.firstname_validate= $scope.img_correct;
        }
        $scope.firstname_validate_style='{}';
    };
}]);