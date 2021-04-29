from django.db import models 
from django.utils.translation import gettext_lazy as _


# Create your models here.
class Card(models.Model):

  text = models.CharField(max_length=200)
  class card_types(models.TextChoices):
    QUESTION = 'QU', _('Question')
    ANSWER = 'AN', _('Answer')

  card_type = models.CharField(max_length=2,choices=card_types)