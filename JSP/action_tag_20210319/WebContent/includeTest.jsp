<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
request.setCharacterEncoding("UTF-8");
String pageName = request.getParameter("pageName");
pageName += ".jsp";
%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	Action 페이지 : includeTest.jsp<br>
	<jsp:include page="<%=pageName %>"></jsp:include>
</body>
</html>