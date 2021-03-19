<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<%
request.setCharacterEncoding("UTF-8");
String name = request.getParameter("name");
String pageName = request.getParameter("pageName");
%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>이름 : <%=name %></h2>
	<h2>페이지 이름 : <%=pageName %></h2>
</body>
</html>