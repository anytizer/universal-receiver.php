import requests

files = {"database": open("sqlite.db", "rb")}
values = {}

r = requests.post(url, files=files, data=values)
