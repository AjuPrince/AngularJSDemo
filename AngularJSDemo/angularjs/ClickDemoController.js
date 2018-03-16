/// <reference path="app.js" />
piloApp.controller('ClickDemoCtrl', ['$http', '$location', '$rootScope', '$scope', function ($http, $location, $rootScope, $scope) {
	$scope.AngularjsButtonClick = function () {
		$scope.ProcessMessage = "The Button Clicked,alert message is :Hello"
	}

}]
);