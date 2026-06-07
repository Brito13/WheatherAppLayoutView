document.querySelector(".lista").addEventListener("DOMContentLoaded", async function ()
{
    const response = await fetch("Country/Details");
    const data = await response.text();
    document.querySelector(".lista").innerHTML = data;
});