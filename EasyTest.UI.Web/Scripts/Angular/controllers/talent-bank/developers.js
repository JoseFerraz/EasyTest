angular.module("easyTest").controller("developersCtrl", function ($scope, $window, developersTalentsApi, modals) {
    $window.onbeforeunload = function () {
        $window.scrollTo(0, 0);
    };

    var getDevelopersTalents = function () {
        developersTalentsApi.getDevelopersTalents().then(
            function successCallback(result) {
                $scope.developersTalents = result.data.reverse();
            },
            function errorCallback() {
                modals.alertResult("Failed to load talents.");
            }
        );
    };

    $scope.openLink = function (link) {
        if (link) {
            window.open(link);
        }
    };

    $scope.deleteDeveloperTalent = function (developerTalent) {
        modals.confirmAction(
            "Are you sure you want to delete record of '" + developerTalent.name + "'?",
            function (result) {
                if (result === true) {
                    developersTalentsApi.deleteDeveloperTalent(developerTalent.id).then(
                        function successCallback() {
                            $scope.developersTalents.splice($scope.developersTalents.indexOf(developerTalent), 1);
                        },
                        function errorCallback() {
                            modals.alertResult("Failed to delete the record.");
                        }
                    );
                }
            }
        );
    };

    $scope.goToTop = function () {
        $("html, body").animate({ scrollTop: 0 }, 1000);
    };

    $(document).ready(function () {
        var windowWidth = $(window).width();

        if (windowWidth < 480) {
            $scope.pagingMaxSize = 5;
        } else if (windowWidth >= 480 && windowWidth < 768) {
            $scope.pagingMaxSize = 7;
        } else if (windowWidth >= 768 && windowWidth < 992) {
            $scope.pagingMaxSize = 11;
        } else if (windowWidth >= 992 && windowWidth < 1200) {
            $scope.pagingMaxSize = 15;
        } else if (windowWidth >= 1200) {
            $scope.pagingMaxSize = 18;
        }
    });

    $(window).scroll(function () {
        if ($(this).scrollTop() > 250) {
            $('.goToTop').fadeIn(200);
        } else {
            $('.goToTop').fadeOut(200);
        }
    });

    var init = function () {
        getDevelopersTalents();
    };

    init();
});