
//old code 1 starts
//angular.module('myApp').controller('LoginController', function($scope, LoginService) {  
//    //initilize user data object  
//    $scope.LoginData = {  
//        Email: '',  
//        Password: ''  
//    }  
//    $scope.msg = "";  
//    $scope.Submited = false;  
//    $scope.IsLoggedIn = false;  
//    $scope.IsFormValid = false;  
//    //Check whether the form is valid or not using $watch  
//    $scope.$watch("myForm.$valid", function(TrueOrFalse) {  
//        $scope.IsFormValid = TrueOrFalse; //returns true if form valid  
//    });  
//    $scope.LoginForm = function() {  
//        $scope.Submited = true;  
//        if ($scope.IsFormValid) {  
//            LoginService.getUserDetails($scope.UserModel).then(function(d) {  
//                debugger;  
//                if (d.data.Email != null) {  
//                    debugger;  
//                    $scope.IsLoggedIn = true;  
//                    $scope.msg = "You successfully Logged in Mr/Ms " + d.data.FullName;  
//                } else {  
//                    alert("Invalid credentials buddy! try again");  
//                }  
//            });  
//        }  
//    }  
//}).factory("LoginService", function($http) {  
//    //initilize factory object.  
//    var fact = {};  
//    fact.getUserDetails = function(d) {  
//        debugger;  
//        return $http({  
//            url: '/Home/VerifyUser',  
//            method: 'POST',  
//            data: JSON.stringify(d),  
//            headers: {  
//                'content-type': 'application/json'  
//            }  
//    });  
//};  
//return fact;  
//});  

//old code 1 ends

//old code 2 starts

//angular.module('MyApp')
//.controller('Part3Controller', function ($scope, LoginService) {
//    $scope.IsLogedIn = false;
//    $scope.Message = '';
//    $scope.Submitted = false;
//    $scope.IsFormValid = false;

//    $scope.LoginData = {
//        Username: '',
//        Password:''
//    };
//    //check is form valid or not //Here f1 is our form name
//    $scope.$watch('f1.$valid', function (newVal) {
//        $scope.IsFormValid = newVal;
//    });
//    $scope.Login = function () {
//        $scope.Submitted = true;
//        if ($scope.IsFormValid) {
//            LoginService.GetUser($scope.LoginData).then(function (d) {
//                if (d.data.Username != null) {
//                    $scope.IsLogedIn = true;
//                    $scope.Message = "Successfully login done. Welcome " + d.data.UserID;
//                }
//                else {
//                    alert('Invalid Credentials');
//                }
//            });
//        }
//    };
//})
//.factory('LoginService', function ($http) {
//    var fac = {};
//    fac.GetUser = function (d) {
//        return $http({
//            url: '/Home/LoginPage1/',
//            method: 'POST',
//            data: JSON.stringify(d),
//            headers: { 'content-type': 'application/json' }
//        });
//    };
//    return fac;
//})

//old code 2 ends


angular.module("tutorialAppControlModule", [])

.controller("TutorialCtrl", ["$scope", "Calculations", function ($scope, Calculations) {
    $scope.tutorialObject = {};
    $scope.tutorialObject.MainTitle = "Main Title";
    $scope.tutorialObject.SubTitle = "Sub Title";
    $scope.tutorialObject.BindOutput = 2;
    $scope.tutorialObject.FirstName = "Thomas";
    $scope.tutorialObject.LastName = "Mark";

    $scope.tutorialObject.BindOutput = 2;
    $scope.MultiplyByTwo = function () {
        $scope.tutorialObject.BindOutput = Calculations.MultiplyByTwo($scope.tutorialObject.BindOutput)
    }
    $scope.tutorialObject.NewCalculatedValue= Calculations.newCalculation(2, 4);
}])

.directive("newWelcomeMessage", function () {
    return {
        restrict: "EA",
        template: "<div>Hi This is the new welcome message hello</div>"
    }
})

.factory("Calculations", function () {
    var calculations = {};

    calculations.MultiplyByTwo = function (a) {
        return a * 2;
    };
    calculations.newCalculation = function (a, b) {
        return (a + b);
        };
    
    return calculations;
});

   