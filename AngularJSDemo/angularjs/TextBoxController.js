/// <reference path="app.js" />
piloApp.controller('textboxCtrl', ['$scope', '$window', function ($scope, $window) {
	$scope.AlertMessage = function () {
		if (typeof ($scope.Name) == 'undefined' || $scope.Name == "") {
			$window.alert("请输入你的名字。");
			return false;
		}
		$window.alert("Hello " + $scope.Name);
	}
}]);