/// <reference path="app.js" />
piloApp.controller('PhoneCtrl', ['$http', '$location', '$rootScope', '$scope', '$window', function ($http, $location, $rootScope, $scope, $window) {
	var obj = {};
	$http({
		method: 'POST',
		url: "/Phone/GetMobilePhones",
		dataType: 'json',
		headers: { 'Content-Type': 'application/json;charset=utf-8' },
		data: JSON.stringify(obj),
	}).then(function (response) {
		$scope.Phones = response.data;
	});

	$scope.GetValues = function () {
		var value = $scope.ddlPhones.ID;
		var text = $scope.ddlPhones.Name;
		$window.alert("选择的Value: " + value + "\n选择的Text: " + text);
	};
}]);