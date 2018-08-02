angular.module("easyTest").controller("developerDetailsCtrl", function ($scope, $window, developersTalentsApi, modals) {
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

    $scope.technologies = [
        { id: "ionic", name: "Ionic" },
        { id: "android", name: "Android" },
        { id: "ios", name: "iOS" },
        { id: "html", name: "HTML" },
        { id: "css", name: "CSS" },
        { id: "bootstrap", name: "Bootstrap" },
        { id: "jQuery", name: "jQuery" },
        { id: "angularJS", name: "AngularJS" },
        { id: "java", name: "Java" },
        { id: "aspNetMvc", name: "ASP.NET MVC" },
        { id: "c", name: "C" },
        { id: "cPlusPlus", name: "C++" },
        { id: "cake", name: "Cake" },
        { id: "django", name: "Django" },
        { id: "magento", name: "Magento" },
        { id: "php", name: "PHP" },
        { id: "vue", name: "Vue" },
        { id: "wordPress", name: "WordPress" },
        { id: "python", name: "Python" },
        { id: "ruby", name: "Ruby" },
        { id: "sqlServer", name: "SQL Server" },
        { id: "mySql", name: "MySQL" },
        { id: "salesforce", name: "Salesforce" },
        { id: "photoshop", name: "Photoshop" },
        { id: "illustrator", name: "Illustrator" },
        { id: "seo", name: "SEO" }
    ];

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

    $scope.openLink = function (link) {
        if (link) {
            window.open(link);
        }
    };

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