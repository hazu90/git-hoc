app_module.directive('showMenubarAlwaysOnTop', ['$window', function ($window) {
    return {
        link: function(scope, element, attrs){
            angular.element($window).bind("scroll", function() {
                if(this.pageYOffset  >100){
                    if(!angular.element( document.querySelector( '#header-toolbar' )).hasClass('fixed') ){
                        angular.element( document.querySelector( '#header-toolbar' )).addClass('fixed');
                    }
                }
                else{
                    if(angular.element( document.querySelector( '#header-toolbar' )).hasClass('fixed') ){
                        angular.element( document.querySelector( '#header-toolbar' )).removeClass('fixed');
                    }
                }
            });
        }
    };
}]);