    function mainController($scope) {
        $scope.message = "Hello, Michael";
    }

    angular
        .module("appName", [])
        .controller("mainController", mainController);
