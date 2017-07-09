var LoginController = function($scope)
{
    this.remember_me = false;
};
LoginController.prototype.change_remember = function(){
    this.remember_me = !this.remember_me;
}
app_module.controller('LoginController',['$scope',LoginController]);
