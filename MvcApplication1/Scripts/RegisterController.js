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

    $scope.pwd='';
    $scope.pwd_validate=$scope.img_correct;
    $scope.pwd_validate_show = false;
    $scope.pwd_lost_focus = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.pwd_validate= $scope.img_noncorrect;
        }
        else
        {
            $scope.pwd_validate= $scope.img_correct;
        }
        $scope.pwd_validate_show=true;
    };

    $scope.confirm_pwd='';
    $scope.confirm_pwd_validate=$scope.img_correct;
    $scope.confirm_pwd_validate_show = false;
    $scope.confirm_pwd_lost_focus = function(input_val){
        if( input_val=== null || input_val === '' )
        {
            $scope.confirm_pwd_validate= $scope.img_noncorrect;
        }
        else
        {
            if($scope.confirm_pwd !== $scope.pwd )
            {
                $scope.confirm_pwd_validate= $scope.img_noncorrect;
            }
            else
            {
                $scope.confirm_pwd_validate= $scope.img_correct;
            }

        }
        $scope.confirm_pwd_validate_show=true;
    };

    $scope.register_submit = function(){
        $scope.firstname_lost_focus($scope.firstname);
        $scope.lastname_lost_focus($scope.lastname);
        $scope.email_lost_focus($scope.email);
        $scope.pwd_lost_focus($scope.pwd);
        $scope.confirm_pwd_lost_focus($scope.confirm_pwd);

        if($scope.firstname_validate_show
            && $scope.lastname_validate_show
            && $scope.email_validate_show
            && $scope.pwd_validate_show
            && $scope.confirm_pwd_validate_show
            )
        {
            $http({
                method:'POST',
                url:'Account/Register',
                data:{
                    FirstName:$scope.firstname,
                    LastName:$scope.lastname,
                    UserEmail:$scope.email,
                    Password:$scope.pwd,
                    ConfirmPassword:$scope.confirm_pwd
                },
                headers:{'Content-Type':'application/json'}
            }).success(function(responseData){
                console.log('Ok then');
            });
        }
    }
}]);