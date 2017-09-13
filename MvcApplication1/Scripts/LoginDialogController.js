app_module.controller('LoginDialogController',['$scope', '$window','$http','dialog_login',function($scope,$window,$http,dialog_login){
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

    $scope.loginFacebook = function(mode){
        $window.open('/ExternalAccount/Login/Facebook?mode='+mode,'','height=340,innerHeight=340,width=680,innerWidth=680,toolbar=no,menubar=no,scrollbars=yes,resizeable=no,location=no,status=no');
    }
    $scope.antiForgeryToken='';
    $scope.userInfo ={
        UserName:'',
        Password :'',
        RememberMe:false
    };
    $scope.login = function(){
        $http({
            method:'POST',
            url:'Account/Login',
            data:$scope.userInfo,
            headers:{
                'Content-Type':'application/json',
                'RequestVerificationToken':  $scope.antiForgeryToken
            }
        }).success(function(responseData){

        });
    }
}]);