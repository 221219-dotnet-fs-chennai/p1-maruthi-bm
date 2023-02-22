async function addUser() {
    const handleeducation = document.getElementById("addCompany");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let userid = localStorage.getItem('Companyid')

    let TrainerIds1 = document.getElementById("TrainerIds").value;
    let CompanyId1 = document.getElementById("CompanyIds").value;
    let TrainerCompany1 = document.getElementById("TrainerCompanys").value;
    let StratDate1 = document.getElementById("StratDates").value;
    let EndDate1 = document.getElementById("EndDates").value;

   


    await fetch("https://localhost:7228/api/Education/FetchCompany",
        {
            method: "POST",
            body: JSON.stringify({
                "CompanyId": CompanyId1,
                "TrainerCompany": TrainerCompany1,
                "Industry": Industry1,
                "StratDate": StratDate1,
                "EndDate": EndDate1,

            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
    alert("added User Details!")
    //window.location.href = "view.html"
}