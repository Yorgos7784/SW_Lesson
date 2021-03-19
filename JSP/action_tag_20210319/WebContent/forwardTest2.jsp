<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
request.setCharacterEncoding("UTF-8");
String id = "Yorgos7784";
String hobby = "영화감상";
%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<jsp:forward page="forwardToTest2.jsp">
		<jsp:param value="<%=id %>" name="id"/>
		<jsp:param value="<%=hobby %>" name="hobby"/>
	</jsp:forward>
</body>
</html>