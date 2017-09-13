app_module.controller('UserInformationController',['$scope',function($scope){
    var arrDay = ['Ngày'];
    for(var i =1;i<=31;i++){
        if(i<10){
            arrDay.push('0'+i);
        }
        else{
            arrDay.push(i);
        }
    }
    $scope.all_day_in_month = arrDay;
    var arrMonth = ['Tháng'];
    for(var i =1;i<=12;i++){
        if(i<10){
            arrMonth.push('0'+i);
        }
        else{
            arrMonth.push(i);
        }
    }
    $scope.all_month_in_year = arrMonth;
    var arrYear = ['Năm'];
    for(var i =1967;i<=2004;i++){
        arrYear.push(i);
    }
    $scope.all_year = arrYear;
    $scope.form_data={};
    $scope.submit_form = function(){
        $http({
            method  : 'POST',
            url     : 'UserInformation/Edit',
            data    : $.param($scope.formData),  // pass in data as strings
            headers : { 'Content-Type': 'application/x-www-form-urlencoded' }  // set the headers so angular passing info as form data (not request payload)
        }).success(function(data) {
                console.log(data);

                if (!data.success) {
                    $scope.errorName = data.errors.name;
                    $scope.errorSuperhero = data.errors.superheroAlias;
                } else {
                    $scope.message = data.message;
                }
            });
    }
}]);