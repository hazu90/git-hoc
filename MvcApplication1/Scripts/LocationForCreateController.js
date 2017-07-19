app_module.controller('LocationForCreateController',['$scope','$http',function($scope,$http){
    $scope.LocationInfo = {
        LocationName : '',
        Address:'',
        CategoryGrId:0,
        CountryId:0,
        ProvinceId:0,
        CityId:'',
        NearBy :'',
        AddressDescription:'',
        PhoneNumber:'',
        Email:'',
        WebsiteUrl:'',
        Description:'',
        NumberOfPersonInRoom:'',
        OpenTime:'',
        ClosedTime:'',
        LastClientInTime:'',
        MinCost:'',
        MaxCost:'',
        LanguageUsed:''
    };
    $scope.LstCountry=[];
    $scope.LstCity =[];
    $scope.LstDistrict=[];

    $scope.LstSelectedCity =[];
    $scope.LstSelectedDistrict=[];
    $scope.LstHour =['00','01','02','03','04','05','06','07','08','09','10','11','12','13','14','15','16','17','18','19','20','21','22','23','24'];
    $scope.LstMinute=['00','15','30','45'];

    $scope.init = function(){
        $http({
            url:'Area/GetAll',
            method:'GET',
            params:{}
        }).then(
            function success(response){
                $scope.LstCountry=response.data.LstCountry;
                $scope.LstCity = response.data.LstCity;
                $scope.LstDistrict = response.data.LstDistrict;
            },
            function error(response){
                console.log(response);
            }
        );
    };
    $scope.change_country = function(){
        if($scope.LocationInfo.CountryId =='' || $scope.LocationInfo.CountryId=='0' )
        {
            $scope.LstSelectedCity = [];
        }
        else
        {
            for(var cityIndex in  $scope.LstCity)
            {
                if($scope.LstCity[cityIndex].CountryId == $scope.LocationInfo.CountryId )
                {
                    $scope.LstSelectedCity.push($scope.LstCity[cityIndex]);
                }
            }
        }
    };
    $scope.change_city = function()
    {
        if($scope.LocationInfo.CityId =='' || $scope.LocationInfo.CityId=='0' )
        {
            $scope.LstSelectedDistrict = [];
        }
        else
        {
            for(var distictIndex in  $scope.LstDistrict)
            {
                if($scope.LstDistrict[distictIndex].CityId == $scope.LocationInfo.CityId )
                {
                    $scope.LstSelectedDistrict.push($scope.LstDistrict[distictIndex]);
                }
            }
        }
    }

}]);