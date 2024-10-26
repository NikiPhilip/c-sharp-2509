function Calculatelargest(){
    let number1=parseFloat(document.getElementById('num1').value);
    let number2=parseFloat(document.getElementById('num2').value);
    let number3=parseFloat(document.getElementById('num3').value);
    let largest=Math.max(number1,number2,number3)

    document.getElementById('largest').innerHTML="The largest number is "+largest 

}