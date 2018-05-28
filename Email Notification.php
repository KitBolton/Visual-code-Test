<?php

if(is_page(file:///D:/Visual%20code%20Test/Updated%20Test%20Page%20(Use%20this).html))
{

$fromName = 'Auto email notification system';

$subject = 'Confirmed';

/* Mail Address */
$toAddr = 'kitbolton884@gmail.com'; 
$bccAddr = 'bccperson@domain.com'; 
$fromAddr = 'no-reply@domain.com';
/* End Mail Address */


/* Mail Body */
$msg = '
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
my messages about confirmation...
</body>
</html>
';

$msg = wordwrap($msg, 70);
/* End Mail Body */


/* Mail Headers Setup */
$headers = array();
$headers[] = "MIME-Version: 1.0";
$headers[] = "Content-type: text/html; charset=utf-8";
$headers[] = "From: ".$fromName." <".$fromAddr.">";
$headers[] = "Bcc: <".$bccAddr.">";
/* End Mail Headers Setup */


mail($toAddr, $subject, $msg, implode("\r\n", $headers));

}

?>