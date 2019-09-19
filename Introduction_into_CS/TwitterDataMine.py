import time
import json
import tweepy
from tweepy import OAuthHandler

key=''
secret=''
tkey=''
tsecret=''


auth = tweepy.OAuthHandler(key,secret)
auth.set_access_token(tkey,tsecret)
api = tweepy.API(auth)


FirstUser=input("First User:")
tweets=api.user_timeline(id=FirstUser,count=10)

def process_or_store(tweet):
    print(json.dumps(tweet))

print("\n")

print("10 recent tweets from "+FirstUser+":")

print("\n")

list1=[]
for tweet in tweets:
        process_or_store(tweet.text)
        list1.append(tweet.text)

num1=[]

for item in list1:
    num1.append(len(item.split()))
x=sum(num1)

print("\n")

user1 = api.get_user(FirstUser)
print("Followers:")
print (user1.followers_count)
f1=user1.followers_count

print("\n")

SecondUser=input("Second User:")
tweets=api.user_timeline(id=SecondUser,count=10)
def process_or_store(tweet):
    print(json.dumps(tweet))

print("\n")

print("10 recent tweets from "+SecondUser+":")

print("\n")

list2=[]
for tweet in tweets:
    process_or_store(tweet.text)
    list2.append(tweet.text)

num2=[]
for item in list2:
    num2.append(len(item.split()))
y=sum(num2)

print("\n")

user2 = api.get_user(SecondUser)
print("Followers:")
print (user2.followers_count)
f2=user2.followers_count

print("\n")

s1=f1*x
s2=f2*y

if s1>s2:
    print(FirstUser+" Has more followers and words in his tweets!")
elif s1<s2:
    print(SecondUser+" Has more followers and words in his tweets!")
else:
    print("Their number of followers and words in tweets are equal!")
print("\n")
