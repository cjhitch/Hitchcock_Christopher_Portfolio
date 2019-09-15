(function(){

    llc = {
        selectors : {
            gradeOne: document.querySelector('.gradeOne'),
            gradeTwo: document.querySelector('.gradeTwo'),
            gradeOneError: document.querySelector('.gradeOneRow p.error'),
            gradeTwoError: document.querySelector('.gradeTwoRow p.error'),
            finalGrade: document.querySelector('.finalGrade'),
            finalGradeText: document.querySelector('.finalGrade h3.finalGradeText'),
            finalText: document.querySelector('.finalText')
        },
        methods: {
            listener : function() {
                llc.selectors.gradeOne.addEventListener('input', function(){
                    llc.methods.inputValidation(parseFloat(llc.selectors.gradeOne.value), llc.selectors.gradeOneError);
                })
                llc.selectors.gradeTwo.addEventListener('input', function(){
                    llc.methods.inputValidation(parseFloat(llc.selectors.gradeTwo.value), llc.selectors.gradeTwoError);
                })
            },
            inputValidation: function(val1, rowSelect) {
                if(!Number.isInteger(val1) || val1 < 0 || val1 > 100){
                    rowSelect.classList.remove('invis');
                }
                else {
                    rowSelect.classList.add('invis');
                }
                llc.methods.gradeCalculate();
            },
            gradeCalculate : function() {
                let grade1 = parseFloat(llc.selectors.gradeOne.value);
                let grade2 = parseFloat(llc.selectors.gradeTwo.value);
                if (llc.selectors.gradeOneError.classList.contains('invis') && llc.selectors.gradeTwoError.classList.contains('invis')){
                    llc.selectors.finalGrade.classList.remove('d-none');
                    let finalGrade = (grade1+grade2)/2;
                    llc.selectors.finalGradeText.innerHTML = finalGrade;
                    if (grade1 >= 70 && grade2 >= 70) {
                        llc.selectors.finalText.innerHTML = `Congrats, both grades are passing!`
                    }
                    else {
                        llc.selectors.finalText.innerHTML = `One or more grades are failing, try harder next time!`
                    }
                }
                else {
                    llc.selectors.finalGrade.classList.add('d-none');
                }
            }       
        },
        init : function() {
            llc.methods.listener();
        }
    }
    llc.init();

})();