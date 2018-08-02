angular.module("easyTest").controller("developersFormCtrl", function ($scope, $window, developersTalentsApi, modals) {
    $window.onbeforeunload = function () {
        $window.scrollTo(0, 0);
    };

    $scope.currentStep = 1;

    $scope.goToStep = function (targetStep) {
        var goToStepFailed = function () {
            $window.scrollTo(0, 0);

            switch ($scope.currentStep) {
                case 1:
                    $scope.developersForm.stepOne.commitFailed = true;
                    break;

                case 2:
                    $scope.developersForm.stepTwo.commitFailed = true;
                    break;

                case 3:
                    $scope.developersForm.stepThree.commitFailed = true;
            }
        };

        var goToStepSuccess = function () {
            $window.scrollTo(0, 0);
            $scope.currentStep = targetStep;
        };

        if (targetStep <= $scope.currentStep) {
            goToStepSuccess();
        } else {
            switch (targetStep) {
                case 2:
                    if ($scope.developersForm.stepOne.$valid) {
                        goToStepSuccess();
                    } else goToStepFailed();
                    break;

                case 3:
                    if ($scope.developersForm.stepOne.$valid && $scope.developersForm.stepTwo.$valid) {
                        goToStepSuccess();
                    } else goToStepFailed();
                    break;

                case 4:
                    if ($scope.developersForm.stepOne.$valid && $scope.developersForm.stepTwo.$valid && $scope.developersForm.stepThree.$valid) {
                        goToStepSuccess();
                    } else goToStepFailed();
            }
        }
    };

    $scope.next = function () {
        var nextStep = function (step) {
            if (step.$valid) {
                $window.scrollTo(0, 0);
                document.activeElement.blur();
                $scope.currentStep++;
            } else {
                $window.scrollTo(0, 0);
                document.activeElement.blur();
                step.commitFailed = true;
            }
        };

        switch ($scope.currentStep) {
            case 1:
                nextStep($scope.developersForm.stepOne);
                break;

            case 2:
                nextStep($scope.developersForm.stepTwo);
                break;

            case 3:
                nextStep($scope.developersForm.stepThree);
        }
    };

    $scope.back = function () {
        $window.scrollTo(0, 0);
        document.activeElement.blur();
        $scope.currentStep--;
    };

    $scope.postDeveloperTalent = function (developerTalent) {
        developersTalentsApi.postDeveloperTalent(developerTalent).then(
            function successCallback() {
                modals.alertResult("Form successfully submitted! / Formulário enviado com sucesso!");
                delete $scope.developerTalent;
                angular.forEach($scope.developersForm, function (step) {
                    step.commitFailed = false;
                });
                $window.scrollTo(0, 0);
                $scope.currentStep = 1;
            },
            function errorCallback() {
                modals.alertResult("Form submission failed! / Falha no envio do formulário!");
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
        { id: "english", description: "English / Inglês" },
        { id: "portuguese", description: "Portuguese / Português" },
        { id: "spanish", description: "Spanish / Espanhol" }
    ];

    $scope.weeklyAvailability = [
        { id: "upTo4HoursPerDay", description: "Up to 4 hours per day / Até 4 horas por dia" },
        { id: "from4To6HoursPerDay", description: "4 to 6 hours per day / De 4 á 6 horas por dia" },
        { id: "from6To8HoursPerDay", description: "6 to 8 hours per day / De 6 á 8 horas por dia" },
        { id: "moreThan8HoursPerDay", description: "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)" },
        { id: "onlyWeekends", description: "Only weekends / Apenas finais de semana" }
    ];

    $scope.preferredPeriod = [
        { id: "morningPeriod", description: "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)" },
        { id: "afternoonPeriod", description: "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)" },
        { id: "nightPeriod", description: "Night (7:00 p.m. to 10:00 p.m.) / Noite (de 19:00 as 22:00)" },
        { id: "dawnPeriod", description: "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)" },
        { id: "businessPeriod", description: "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)" }
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