<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	// 주석 java하고 똑같이 쓸 수 있음
	int num1 = 100;
	int num2 = 200;
	int result = num1 + num2;
	String name = "Yorgos";
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>스트립틀릿</title>
</head>
<body>
	<div><% out.print(result); %></div>
	<div><% out.println(num1 + num2); %></div>
	<div><h1>연산 결과 : <%=result %></h1></div>
	<div><h2>이름 : <%=name %></h2></div>
</body>
</html>