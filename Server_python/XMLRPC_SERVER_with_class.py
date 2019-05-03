from xmlrpc.server import SimpleXMLRPCServer


from xmlrpc.server import SimpleXMLRPCServer

# def add(n):
#     return  n+1
#
# def is_even(n):
#     return n % 2 == 0
class key:
    def is_even(self,n):
        return n % 2 == 0

    def add(self,a,b):
        return a+b

Key=key()
server = SimpleXMLRPCServer(("0.0.0.0", 8081))
print("Listening on port 8081...")
server.register_instance(Key)
# server.register_function(is_even)
# server.register_function(add)
server.serve_forever()


