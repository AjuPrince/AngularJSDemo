/// <reference path="app.js" />
piloApp.controller('CarCtrl', ['$http', '$scope', '$window', function ($http, $scope, $window) {
	var obj = {};
	$http({
		mothod: 'POST',
		url: "/Car/GetCars",
		dataType: 'json',
		headers: {
			'Content-Type': 'application/json;charset=utf-8'
		},
		data: JSON.stringify(obj),
	}).then(function (response) {
		$scope.Cars = response.data;
	});
	$scope.GetValues = function () {
		var value = $scope.SelectedCar.ID;
		var text = $scope.SelectedCar.Name;
		$window.alert("选择的Value: " + value + "\n选择的Text: " + text);
	};
}]);