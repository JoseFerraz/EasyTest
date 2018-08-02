angular.module("easyTest").controller("developerEditCtrl", function ($scope, $window, developersTalentsApi, modals) {
    $window.onbeforeunload = function () {
        $window.scrollTo(0, 0);
    };

    $scope.getDeveloperTalent = function (id) {
        developersTalentsApi.getDeveloperTalent(id).then(
            function successCallback(result) {
                $scope.developerTalent = result.data;
            },
            function errorCallback() {
                modals.alertResult("An error has occurred!");
            }
        );
    };

    $scope.currentStep = 1;

    $scope.goToStep = function (targetStep) {
        $window.scrollTo(0, 0);
        $scope.currentStep = targetStep;
    };

    $scope.putDeveloperTalent = function (developerTalent) {
        modals.confirmAction(
            "Are you sure you want to save your changes?",
            function (result) {
                if (result === true) {
                    if ($scope.fullForm.$valid) {
                        developersTalentsApi.putDeveloperTalent(developerTalent).then(
                            function successCallback() {
                                modals.alertResult("Successfully edited record!", function () {
                                    window.location.replace("http://localhost:58106/talent-bank/developers");
                                });
                            },
                            function errorCallback() {
                                $window.scrollTo(0, 0);
                                modals.alertResult("Failed to edit record!");
                            }
                        );
                    } else {
                        $window.scrollTo(0, 0);

                        $scope.$apply(function () {
                            $scope.fullForm.commitFailed = true;
                        });

                        modals.alertResult("Invalid form, make sure all required information has been entered!");
                    }
                }
            }
        );
    };

    $scope.technologies = [
        { id: "ionic", name: "Ionic", required: true },
        { id: "android", name: "Android", required: true },
        { id: "ios", name: "iOS", required: true },
        { id: "html", name: "HTML", required: false },
        { id: "css", name: "CSS", required: false },
        { id: "bootstrap", name: "Bootstrap", required: true },
        { id: "jQuery", name: "jQuery", required: true },
        { id: "angularJS", name: "AngularJS", required: true },
        { id: "java", name: "Java", required: false },
        { id: "aspNetMvc", name: "ASP.NET MVC", required: true },
        { id: "c", name: "C", required: false },
        { id: "cPlusPlus", name: "C++", required: false },
        { id: "cake", name: "Cake", required: false },
        { id: "django", name: "Django", required: false },
        { id: "magento", name: "Magento", required: false },
        { id: "php", name: "PHP", required: true },
        { id: "vue", name: "Vue", required: true },
        { id: "wordPress", name: "WordPress", required: true },
        { id: "python", name: "Python", required: false },
        { id: "ruby", name: "Ruby", required: false },
        { id: "sqlServer", name: "SQL Server", required: false },
        { id: "mySql", name: "MySQL", required: false },
        { id: "salesforce", name: "Salesforce", required: false },
        { id: "photoshop", name: "Photoshop", required: false },
        { id: "illustrator", name: "Illustrator", required: false },
        { id: "seo", name: "SEO", required: false }
    ];

    $scope.technologyLevels = [0, 1, 2, 3, 4, 5];

    $scope.languages = [
        { id: "english", description: "English" },
        { id: "portuguese", description: "Portuguese" },
        { id: "spanish", description: "Spanish" }
    ];

    $scope.weeklyAvailability = [
        { id: "upTo4HoursPerDay", description: "Up to 4 hours per day" },
        { id: "from4To6HoursPerDay", description: "4 to 6 hours per day" },
        { id: "from6To8HoursPerDay", description: "6 to 8 hours per day" },
        { id: "moreThan8HoursPerDay", description: "Up to 8 hours a day (are you sure?)" },
        { id: "onlyWeekends", description: "Only weekends" }
    ];

    $scope.preferredPeriod = [
        { id: "morningPeriod", description: "Morning (from 08:00 to 12:00)" },
        { id: "afternoonPeriod", description: "Afternoon (from 1:00 p.m. to 6:00 p.m.)" },
        { id: "nightPeriod", description: "Night (7:00 p.m. to 10:00 p.m.)" },
        { id: "dawnPeriod", description: "Dawn (from 10 p.m. onwards)" },
        { id: "businessPeriod", description: "Business (from 08:00 a.m. to 06:00 p.m.)" }
    ];

    $scope.goToTop = function () {
        $("html, body").animate({ scrollTop: 0 }, 1000);
    };

    $(window).scroll(function () {
        if ($(this).scrollTop() > 250) {
            $('.goToTop').fadeIn(200);
        } else {
            $('.goToTop').fadeOut(200);
        }
    });
});