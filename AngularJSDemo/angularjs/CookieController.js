/// <reference path="app.js" />
piloApp.controller('CookieCtrl', ['$scope', '$window', '$cookieStore', function ($scope, $window, $cookieStore) {
	$scope.Write_Cookie = function () {
		$cookieStore.put('CookieValues', $scope.CookieValues);
	}
	$scope.Read_Cookie = function () {
		$window.alert($cookieStore.get('CookieValues'));
	}
	$scope.Remove_Cookie = function () {
		$cookieStore.remove('CookieValues');
	}
}]);