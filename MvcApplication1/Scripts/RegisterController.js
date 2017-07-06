app_module.controller('RegisterController',['$scope',function($scope){
    $scope.img_correct='../Content/img/correct-icon.png';
    $scope.img_noncorrect='../Content/img/uncorrect-icon.png';
    //
    $scope.firstname='';
    $scope.firstname_validate=$scope.img_correct;
    $scope.firstname_validate_show=false;
    $scope.firstname_lost_focus = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.firstname_validate= $scope.img_noncorrect;
        }
        else
        {
            $scope.firstname_validate= $scope.img_correct;
        }
        $scope.firstname_validate_show=true;
    };

    $scope.lastname='';
    $scope.lastname_validate=$scope.img_correct;
    $scope.lastname_validate_show=false;
    $scope.lastname_lost_focus = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.lastname_validate= $scope.img_noncorrect;
        }
        else
        {
            $scope.lastname_validate= $scope.img_correct;
        }
        $scope.lastname_validate_show=true;
    };

    $scope.email='';
    $scope.email_validate=$scope.img_correct;
    $scope.email_validate_show=false;
    $scope.email_lost_focus = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.email_validate= $scope.img_noncorrect;
        }
        else
        {
            $scope.email_validate= $scope.img_correct;
        }
        $scope.email_validate_show=true;
    };
}]);