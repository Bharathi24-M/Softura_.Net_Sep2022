const CalculateBill=()=>{
        let BillAmount=parseInt(document.getElementById("BAmount").value);
    let Tips=parseInt(document.getElementById("TAmount").value);
    let tipsAmount=(BillAmount*(Tips/100));
    let NetAmount=tipsAmount+BillAmount;  
    document.getElementById("BAmount1").innerHTML=
    "Bill Amount :"+BillAmount;
    document.getElementById("TAmount1").innerHTML=
    "Tips Amount :"+tipsAmount;
    document.getElementById("NAmount").innerHTML=
    "The Net Amount to pay is :"+NetAmount;
};