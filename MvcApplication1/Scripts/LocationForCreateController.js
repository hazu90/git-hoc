app_module.controller('LocationForCreateController',['$scope',function($scope){
    $scope.LocationInfo = {
        LocationName : '',
        Address:'',
        CategoryGrId:0,
        CountryId:0,
        ProvinceId:0,
        CityId:0,
        NearBy :'',
        AddressDescription:'',
        PhoneNumber:'',
        Email:'',
        WebsiteUrl:'',
        Description:'',
        NumberOfPersonInRoom:0,
        OpenTime:'',
        ClosedTime:'',
        LastClientInTime:'',
        MinCost:'',
        MaxCost:'',
        LanguageUsed:''
    };

    $scope.post_add_location = function(){
        if($scope.LocationInfo.LocationName=== null || $scope.LocationInfo.LocationName=== '')
        {

        }
    }
}]);