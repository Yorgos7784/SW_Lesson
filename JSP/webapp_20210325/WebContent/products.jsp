<%@page import="java.util.Locale"%>
<%@page import="com.mk.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session" />

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>Product List</title>
</head>
<body>
	<jsp:include page="menu.jsp"/>
	<div class="jumbotron">
		<div class="container">
			<h1 class=display-3>Product List</h1>
		</div>
	</div>
	
	<%
	ArrayList<Product> list = productDAO.getAllProduct();
	Locale locale = new Locale("ko", "KR");
	
	%>
	
	<div class="container">
		<div class="row" align="center">
			<%
			
			for(int i = 0; i < list.size(); i++){
				Product product = list.get(i);
				int price = product.getUnitPrice();
				String strPrice = locale.getCountry() + " " + String.format(Locale.KOREAN, "%,d", price);
			%>
			<div class="col-md-4">
				<h3><%=product.getPname() %></h3>
				<p><%=product.getDescription() %>
				<p><%=strPrice %> ￦
				<p><a href="product.jsp?id=<%=product.getProductId() %>" class="btn btn-secondary" role="button">Detail Info &raquo;</a>
			</div>
			<% } %>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>