<html>
<script>
funciton affcliwor()
{
FIXME_VAR_TYPE mylist= document.getElementById("myList");
document.getElementById("Affect").value=mylist.options(mylist.selectIndex).text;
}


</script>

<body>
<h1

<form>
<b>Afffect Client Workflow</b> 
<select id="myList" onchange="affcliwor">
    <option>Yes-Critical</option>
    <option>Yes-Non-Critical</option>
    <option>No</option>
</select>
</form> 


<form>
<b>Afffecting Applicants Applying</b>
<select id="myList" onchange="affcliwor">
    <option>Yes-Critical</option>
    <option>Yes-Non-Critical</option>
    <option>No</option>
</select>
</form> 


<form>
<b>New Clients 60 Day Since Signup</b>
<select id="myList" onchange="affcliwor">
    <option>Yes</option>
    <option>No</option>
</select>
</form> 


<form>
<b>Client On Trial</b>
<select id="myList" onchange="affcliwor">
    <option>Yes</option>
    <option>No</option>
</select>
</form> 


<form>
<p><b>Client Score<b> <input type="text" id="score" size="20"></p>
</form> 


<form>
<b>WorkAround</b>
<select id="myList" onchange="affcliwor">
    <option>Yes Full</option>
    <option>Yes Partial</option>
    <option>No</option>
</select>
</form>

<html>
<body>

<button type="button" onclick="alert('Client Low')">Check Bug Priority</button>
 
</body>
</html>



</body>

</html>